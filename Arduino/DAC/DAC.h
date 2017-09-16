#ifndef DAC_h
#define DAC_h

#include <Arduino.h>


class DAC {
	
public:
	DAC(uint8_t spin);
	byte write(uint16_t bytewrite);
	
private:
	byte MSB;
	byte LSB;
	int data;
	int lspin;
};

#endif