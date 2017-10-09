#ifndef AD7715_h
#define AD7715_h

#include <stdint.h>
#include <Arduino.h>
#include <SPI.h>

class AD7715 {
	
public:
	static const uint8_t bitres = 16;
	static const uint16_t res = (1 << bitres);
	

	// Commun Reg
	enum Reg {
		Commun = 0x00,
		Setup = 0x10,
		Test = 0x20,
		Data = 0x30
	};
	
	enum RW {
		R = 0x08,
		W = 0x00
	};
	enum Stby {
		ston = 0x04,
		stoff = 0x00
	};
	enum Gain {
		G1 = 0x00,
		G2 = 0x01,
		G32 = 0x02,
		G128= 0x03
	};
	
	// Setup Reg
	enum Mode {
		Normal = 0x00,
		SelfCal = 0x40,
		ZeroScal = 0x80,
		FullScal = 0xC0
	};
	enum CLK {
		Min = 0x00,
		Max = 0x20
	};
	enum Outputrate {
		FMin = 0x00,
		FLow = 0x08,
		FHigh = 0x10,
		FMax = 0x18
	};
	enum BU {
		bi = 0x00,
		uni = 0x04
	};
	enum Buff {
		bufon = 0x02,
		bufoff = 0x00
	};
	enum Fsync {
		syncon = 0x01,
		syncoff = 0x00
	};
	
	AD7715(uint16_t vref, uint8_t spin, uint8_t drdy, Gain G);
	uint16_t Init(Mode mode, CLK clk, Outputrate out, BU bu, Buff buff, Fsync sync);
	uint16_t readdata();

	private:
	
	byte backmsb;
	byte backlsb;
	uint16_t back;
	
	byte datareg;
	byte comreg;
	byte setupreg;
	
	uint16_t lvref;
	uint8_t lspin;
	uint8_t ldrdy;
	byte setgain;
	
};


#endif