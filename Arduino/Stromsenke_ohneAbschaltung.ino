// Librarys 
#include <SPI.h>
#include <DACMCP4821.h>  
#include <PID_v1.h>
#include <Mcp3208.h>

#define PIN_5V      7         // Strommessungs V-Ref ADC auf 5V
#define PIN_TO      8         // Strommessungs V-Ref ADC auf 1V

#define SPI_CS    	10 	      // SPI slave select ADC
#define ADC_VREF    1000      // 1V Vref für Berrechnungen
#define ADC_CLK     9000000   // SPI clock 9MHz

int ames[50];                 // Array für 50 Messungen -> Mittelwert wird daraus gezogen. 


MCP3208 adc(ADC_VREF, SPI_CS);    // initialisiere den ADC "MCP3208" mit (VRef, SPI-Slave select)

double Setpoint, LOAD, DA;    
// Setpoint = Einstellwert für DAC,
//LOAD = Mittelwert des Analog Read Arrays,
//DA errechneter Wert des PID Codes 

double In = 0.100;        // Einstellen des Stromwert in mA
double oben;              // Obere Totzeit
double unten;             // Untere Totzeit

int da_1;                 // Double DA in int da_1
int outputAnalog;         // Int an DAC 
int delayloop = 100;      //Variable Zeitkonstante

double Kp = 0.1, Ki = 1.0, Kd = 0;   // Anteile des PIDs

PID myPID(&LOAD, &DA, &Setpoint, Kp, Ki, Kd, DIRECT);
//initialisiere Befehl PID  myPID mit Variablen // DIRECT aus PID_v1.h


DACMCP4821 dac(2, 7, 4);  // Pin Belegung, CS,LDAC,SHUTD

byte ganancia;            // Für die Library relevant

void setup() {

  pinMode(PIN_TO, OUTPUT);  // Setzte den Pin mit der Zahl PIN_TO als Output.
  pinMode(PIN_5V, OUTPUT);  // Setzte den Pin mit der Zahl PIN_5V als Output.
  pinMode(SPI_CS, OUTPUT);  // Setzte den Pin mit der Zahl SPI_CS als Output.
  
  digitalWrite(PIN_5V, HIGH); // Setzte den Pin mit der Zahl PIN_5V auf (High) 5V.
  digitalWrite(SPI_CS, LOW);  // Setzte den Pin mit der Zahl SPI_CS auf (Low) 0V.
  
  Serial.begin(9600); // Beginne eine Seriele Verbindung mit einer Baudrate von 9600.

  dac.initDAC(); // macht halt sachen

  Setpoint = (In * 4096); // In (Eingestellter Stromwert) * 4096 
  Serial.println(Setpoint); // Gebe den Wert Setpoint per Serialport aus. 
  
  myPID.SetMode(AUTOMATIC); // PID Mode auswahl -> Library für mehr möglichkeiten

  SPISettings settings(ADC_CLK, MSBFIRST, SPI_MODE0); // https://www.arduino.cc/en/Reference/SPISettings
  SPI.begin();                                        // https://www.arduino.cc/en/Reference/SPIBegin
  SPI.beginTransaction(settings);                     // https://www.arduino.cc/en/Reference/SPIbeginTransaction

}

void loop() {
  Serial.print("Setpoint: "); // Gebe den String "Setpoint: " per Serialport aus. 
  Serial.println(Setpoint); // Gebe den Wert Setpoint per Serialport aus. 

  analogI(); // Verarbeiten / Lesen des Analogwertes

  if (LOAD > (oben = Setpoint + 0.1) || LOAD < (unten = Setpoint - 0.1)) // Totzeit + / - des Setpoints

  {
    myPID.Compute();                          // Berrechnen des Regelwertes                  
    da_1 = DA;                                // Setzte Variable DA und da_1 gleich
    outputAnalog = da_1 + 1065;               // Start bei 5 mA -> 1065: Schneller anstieg.  
    Serial.print("OUT: ");                    // Gebe den String "OUT: " per Serialport aus. 
    Serial.println(outputAnalog);             // Gebe den Wert outputAnalog per Serialport aus. 
    byte msb = dac.writeDAC(outputAnalog, 1); // writeDAC(Input_ADC, Gainfactor) Gainfactor = 1 || 2
  }
  else {
    Serial.println("Wait");                   // Gebe den String "Wait " per Serialport aus. 
  }
  delay(delayloop);                           // Warte die bestimmte Zeit delayloop
}

void analogI() {

  digitalWrite(SPI_CS, HIGH);   // Setzte den Pin mit der Zahl SPI_CS auf (High) 5V.
  digitalWrite(PIN_TO, HIGH);   // Setzte den Pin mit der Zahl PIN_TO auf (High) 5V.

  for (int i = 0; i < 50; i++) { // For Schleife die sich 50 mal wiederholt.
    ames[i] = adc.read(MCP3208::SINGLE_0); // read(Channel) -> alle channel in der Library aufgelistet. 

  }
  for (int j = 0; j < 50; j++) {  // For Schleife die sich 50 mal wiederholt.
    LOAD = LOAD + ames[j];        // Addiere jeden Wert in ames mit LOAD
  }
  LOAD = LOAD / 50;               // Mittelwert aus LOAD ziehen

  digitalWrite(PIN_TO, LOW);      // Setzte den Pin mit der Zahl PIN_TO auf (Low) 0V.
  digitalWrite(SPI_CS, LOW);      // Setzte den Pin mit der Zahl SPI_CS auf (Low) 0V.
  Serial.print("LOAD: ");         // Gebe den String "LOAD: " per Serialport aus. 
  Serial.println(LOAD);           // Gebe den Wert LOAD per Serialport aus. 
  
}
