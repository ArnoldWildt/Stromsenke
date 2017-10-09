#include <SPI.h>
#include <AD7705.h>

AD7705 adc(5000, 10, 8, AD7705::G1, AD7705::AIN1);



void setup() {
  Serial.begin(9600);
  SPI.begin();
  SPI.setClockDivider(SPI_CLOCK_DIV4);
  
  adc.Init( AD7705::Normal, AD7705::bufoff, AD7705::bi, AD7705::syncoff,
            AD7705::clkdisoff, AD7705::clknormal, AD7705::clkmax, AD7705::fmax);

}

void loop() {
  adc.readdata();
  delay(1000);
}
