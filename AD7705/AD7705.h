#ifndef AD7705_h
#define AD7705_h

#include <stdint.h>
#include <Arduino.h>
#include <SPI.h>

class AD7705 {
	
public:

	//static const uint8_t bitres = 16;
	//static const uint16_t res = (1 << bitres);
	
	// Commun Reg
	enum Reg {
		Commun = 0x00,
		Setup = 0x10,
		Clock = 0x20,
		Data = 0x30,
		Test = 0x40,
		No_Operation = 0x50,
		Offset = 0x60,
		Gainreg = 0x70		
	};
	enum RW {
		Read = 0x08,
		Write = 0x00
	};
	enum Stby {
		stbyon = 0x04,
		stbyoff = 0x00
	};
	enum Channel {
		AIN1 = 0x00,
		AIN2 = 0x01,
		AIN3 = 0x03,
		COMMON = 0x02
	};
	
	// Setup Reg
	enum Mode {
		Normal = 0x00,
		SelfCal = 0x40,
		ZeroScal = 0x80,
		FullScal = 0xC0
	};
	enum Gain {
		G1 = 0x00,
		G2 = 0x08,
		G4 = 0x10,
		G8 = 0x18,
		G16 = 0x20,
		G32 = 0x28,
		G64 = 0x30,
		G128 = 0x38		
	};
	enum Buff {
		bufon = 0x02,
		bufoff = 0x00
	};
	enum BU {
		bi = 0x00,
		uni = 0x04
	};
	enum Fsync {
		syncon = 0x01,
		syncoff = 0x00
	};
	
	// Clock Register
	enum Clkdis {
		clkdisoff = 0x00,
		clkdison = 0x10
	};
	enum Clkdiv {
		clkdouble = 0x08,
		clknormal = 0x00
	};
	enum Clk {
		clkmin = 0x80,
		clkmax = 0x00
	};
	enum Outputrate {
		fmin = 0x00,
		flow = 0x01,
		fhigh = 0x02,
		fmax = 0x03
	};
	
	AD7705(uint16_t vref, uint8_t spin, uint8_t drdy, Gain G, Channel ch);
	uint16_t Init(Mode mode, Buff buff, BU bu, Fsync sync, Clkdis clkdis, Clkdiv clkdiv, Clk clk, Outputrate out);
	uint16_t readdata();

	private:
	
	byte backmsb;
	byte backlsb;
	uint16_t back;
	
	byte datareg;
	byte comreg;
	byte comreg1;
	byte setupreg;
	byte clockreg;
	byte comreg_intodata;
	
	uint16_t lvref;
	uint8_t lspin;
	uint8_t ldrdy;
	byte lch;
	byte setgain;
	
};


#endif