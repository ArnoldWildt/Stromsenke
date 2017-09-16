#ifndef ADC_h
#define ADC_h

#include <stdint.h>
#include <Arduino.h>
#include <SPI.h>

class ADC {
	
public:
	static const uint8_t bitres = 16;
	static const uint16_t res = (1 << bitres);
	
	
}