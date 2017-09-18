// PINS
//  A0 LOAD
//  2 / 7 / 4 // DAC // CS / Shutdown / LDAC
//  SDI Pin to MOSI Pin 11
//  SCK Pin to SCK Pin 13

#include <SPI.h>
#include <DACMCP4821.h>  // Librarys 
#include <PID_v1.h>
#include <Mcp3208.h>

#define PIN_LOAD A0                   // Pin Load#
#define PIN_5V 7                // Strommessungs A-ref
#define PIN_TO 8

int ames[50];

#define SPI_CS    	10 	      // SPI slave select
#define ADC_VREF    1000              // 1V Vref
#define ADC_CLK     9000000           // SPI clock 9MHz

MCP3208 adc(ADC_VREF, SPI_CS);

double Setpoint, LOAD, DA;            // Double Variablen
int da_1;                             // Umwandlung
double Kp = 0.1, Ki = 1.0, Kd = 0;   // Anteil des PIDs

PID myPID(&LOAD, &DA, &Setpoint, Kp, Ki, Kd, DIRECT);
//initialisiere Befehl PID  myPID mit Variablen // DIRECT aus PID_v1.h
int xxx = 100;                         //Variable Zeitkonstante


DACMCP4821 dac(2, 7, 4);              // Pin Belegung, CS,LDAC,SHUTD

int outputAnalog;                     // Analoger Wert in Bits als         
double oben;
double unten;
byte ganancia; 

void setup() {

  pinMode(PIN_TO, OUTPUT);
  pinMode(PIN_5V, OUTPUT);
  digitalWrite(PIN_5V, HIGH);

  Serial.begin(9600);

  dac.initDAC();

  pinMode(SPI_CS, OUTPUT);
  digitalWrite(SPI_CS, LOW);

  //LOAD = analogRead(PIN_LOAD);
  
  double In = 0.100;
  
  Setpoint = (In * 4096); // Einstellung des Stromes
  Serial.println(Setpoint);
  myPID.SetMode(AUTOMATIC);

  SPISettings settings(ADC_CLK, MSBFIRST, SPI_MODE0);
  SPI.begin();
  SPI.beginTransaction(settings);

}

void loop() {
  Serial.print("Setpoint: ");
  Serial.println(Setpoint);

  analogI();
  //Serial.println(LOAD);

  if (LOAD > (oben = Setpoint + 0.1) || LOAD < (unten = Setpoint - 0.1))

  {
    myPID.Compute();                                       //
    da_1 = DA;
    outputAnalog = da_1 + 1065;
    Serial.print("OUT: ");
    Serial.println(outputAnalog);
    byte msb = dac.writeDAC(outputAnalog, 1);
    Serial.print("MSB: ");
    Serial.println(msb, HEX);
  }
  else {
    Serial.println("Wait");
  }
  delay(100);

  if (LOAD > 145)
  {
    xxx = 10;
  }


}

void analogI() {

  digitalWrite(SPI_CS, HIGH);
  digitalWrite(PIN_TO, HIGH);

  for (int i = 0; i < 50; i++) {
    ames[i] = adc.read(MCP3208::SINGLE_0);
    //delay(10);
  }
  for (int j = 0; j < 50; j++) {
    LOAD = LOAD + ames[j];
    Serial.print(ames[j]);
    Serial.print(" ");
  }
  LOAD = LOAD / 50;
 // Serial.println(ames[1]);

  digitalWrite(SPI_CS, LOW);
    Serial.print("LOAD: ");
    Serial.println(LOAD);
  //Serial.print("DAC: ");
  //Serial.println(msb, HEX);  
  digitalWrite(PIN_TO, LOW);
}

/*void analogV() {
  
  digitalWrite(PIN_5V,HIGH)
  digitalWrite(SPI_CS,HIGH)*/
  
  
  

