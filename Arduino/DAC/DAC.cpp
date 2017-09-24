#include <DAC.h>
#include <SPI.h>
#include "Arduino.h"

DAC::DAC(uint8_t spin){
	
	lspin = spin;
	pinMode(lspin, OUTPUT);
	digitalWrite(lspin,HIGH);
}

byte DAC::write(uint16_t bytewrite){
	
	data = bytewrite | 0x0000;
	MSB = (data & 0xff00) >> 8;
	LSB = data & 0xff;
	digitalWrite(lspin,LOW);
	SPI.transfer(MSB);
	SPI.transfer(LSB);
	digitalWrite(lspin,HIGH);
	
}