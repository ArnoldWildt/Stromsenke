#include <AD7715.h>
#include <SPI.h>
#include "Arduino.h"

AD7715::AD7715(uint16_t vref, uint8_t spin, uint8_t drdy, Gain G){
	
	setgain = G;
	lvref = vref;
	lspin = spin;
	ldrdy = drdy;
	
	pinMode(ldrdy, INPUT);
	pinMode(lspin, OUTPUT);
}
uint16_t AD7715::Init(Mode mode, CLK clk, Outputrate out,BU bu, Buff buff, Fsync sync){
	
	comreg = 0x00;
	setupreg = 0x00;
	
	// Bit manipulation OR
	comreg = comreg | 0x10 | setgain;   // 0x10 = Setupreg
	setupreg = setupreg | clk | out | bu | buff | sync;
	
	// SPI Transfer
	digitalWrite(lspin,LOW);
	SPI.transfer(comreg);
	SPI.transfer(setupreg);
	digitalWrite(lspin,HIGH);
	
	// Debug
	Serial.print("Comreg: ");
	Serial.println(comreg, HEX);
	Serial.print("Setupreg: ");
	Serial.println(setupreg, HEX);
	
}
uint16_t AD7715::readdata(){
	datareg = 0x00;
	
	datareg = datareg | setgain | 0x38;   // 0x38 = Datareg + Read
	
	// DRDY Pin Polling
	int drdystate = digitalRead(ldrdy);
	
	while (drdystate == 0){
		drdystate = digitalRead(ldrdy);
		Serial.println(drdystate);
	}
	
	digitalWrite(lspin,LOW);
	
	SPI.transfer(datareg);
	
	backmsb = SPI.transfer(0x00);
	delayMicroseconds (20);
	backlsb = SPI.transfer(0x00);
	delayMicroseconds (20);
	
	digitalWrite(lspin,HIGH);
	
	back = backmsb;
	back <<= 8;
	back |= backlsb;
	
	//Debug
	Serial.print("Back: ");
	Serial.println(back, HEX);
	Serial.print("Datareg: ");
	Serial.println(datareg, HEX);
	
}