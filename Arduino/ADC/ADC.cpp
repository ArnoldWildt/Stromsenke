#include "adc.h"
#include <SPI.h>

ADC::ADC(uint16_t vref, uint8_t spin){
	
	lvref = vref;
	lspin = spin;

}

uint16_T ADC::read(){
	byte regbits = B00000000;

	byte back = SPI.transfer(regbits);
	delayMicroseconds (20);
	return back;
}