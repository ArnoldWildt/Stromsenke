String detect = "A";
char detbuff [20];
String curr = "I";
char currbuff [20];
String volt = "V";
char voltbuff [20];
String cancle = "C";
char cancbuff [20];


boolean inpvolt = false;
boolean inpcurr = false;

String inputString = "";
char inputchars[20];
boolean stringComplete = false;

String voltnumb;
String currnumb;

void setup(){
   Serial.begin(9600); 
   pinMode(13, OUTPUT);
   digitalWrite(13, LOW);
}

void loop(){

  if(stringComplete){
  
    digitalWrite(13, HIGH);

    detect.toCharArray(detbuff, 20);
    curr.toCharArray(currbuff, 20);
    volt.toCharArray(voltbuff, 20);
    cancle.toCharArray(cancbuff,20);
    inputString.toCharArray(inputchars, 20);
    
    //Serial.println(inputString);
  
    if (detbuff[0] == inputchars[0])
      {
      Serial.println("Arduino");
      }
      
      if (currbuff[0] == inputchars[0])
        {
         for (int i = 2; i < (strlen(inputchars)- 1); i++){
            currnumb += inputchars[i]; 
            }
            
         currnumb.toFloat();
         Serial.print("Current: ");
         Serial.println(currnumb);
         currnumb = "";
         inpcurr = true;
         }
         
      if (voltbuff[0] == inputchars[0])
        {
        for (int i = 2; i < (strlen(inputchars)- 1); i++){
          voltnumb += inputchars[i]; 
          }
        voltnumb.toFloat();
        Serial.print("Voltage: ");
        Serial.println(voltnumb);
        voltnumb = "";
        inpvolt = true;
        }
       
    stringComplete = false;
    inputString = "";
  }

  while(inpcurr){
    digitalWrite(13, HIGH);
    delay(500);
    digitalWrite(13, LOW);
    delay(500);
    serialEvent();
    inputString.toCharArray(inputchars, 20);
    
      if (cancbuff[0] == inputchars[0])
        {
        Serial.println("Cancled");
        inpvolt = false;
        inpcurr = false;
        inputString = "";
        }
    
    }
  
}


void serialEvent() {
  while (Serial.available()) {

    char inChar = (char)Serial.read();

    inputString += inChar;

    if (inChar == '$') {
      stringComplete = true;
      //Serial.println(inputString);
    }
  }
}

