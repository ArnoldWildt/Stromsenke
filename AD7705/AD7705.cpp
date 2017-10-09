#include <AD7705.h>
#include <SPI.h>
#include "Arduino.h"

AD7705::AD7705(uint16_t vref, uint8_t spin, uint8_t drdy, Gain G, Channel ch){
	
	setgain = G;
	lvref = vref;
	lspin = spin;
	ldrdy = drdy;
	lch = ch;
	
	pinMode(ldrdy, INPUT);
	pinMode(lspin, OUTPUT);
}
uint16_t AD7705::Init(Mode mode,Buff buff, BU bu, Fsync sync, Clkdis clkdis, Clkdiv clkdiv, Clk clk, Outputrate out){
	
	comreg	= 0x00;
	comreg1 = 0x00;
	
	setupreg = 0x00;
	clockreg = 0x00;
	
	// Bit manipulation OR
	comreg = comreg | 0x20 | lch;   // Comreg -> Clockreg , Input Channel
	clockreg = clockreg | clkdis | clkdiv | clk | out;
	
	comreg1 = comreg1 | 0x10 | lch;   // 0x10 = Setupreg
	setupreg = mode | setgain | bu | buff | sync;
	
	// SPI Transfer
	digitalWrite(lspin,LOW);
	
	SPI.transfer(comreg);
	SPI.transfer(clockreg);
	
	SPI.transfer(comreg1);
	SPI.transfer(setupreg);
	
	digitalWrite(lspin,HIGH);
	
	// Debug
	Serial.print("Comreg: ");
	Serial.println(comreg, HEX);
	Serial.print("Setupreg: ");
	Serial.println(setupreg, HEX);
	
}
uint16_t AD7705::readdata(){
	datareg = 0x00;
	
	comreg_intodata = datareg | lch | 0x08;   // 0x38 = Datareg + Read
	
	// DRDY Pin Polling
	int drdystate = digitalRead(ldrdy);
	
	while (drdystate == 0){
		drdystate = digitalRead(ldrdy);
		Serial.println(drdystate);
	}
	
	digitalWrite(lspin,LOW);
	
	SPI.transfer(comreg_intodata);
	
	backmsb = SPI.transfer(0x00); // first one LSB ? MSB ? Research needed
	delayMicroseconds (20); // needed ?
	backlsb = SPI.transfer(0x00);
	delayMicroseconds (20); // needed ?
	
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