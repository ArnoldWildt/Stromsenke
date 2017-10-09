#include <SPI.h>
#include <AD7715.h>

AD7715 adc(5000, 10, 8, AD7715::G2);



void setup() {
  Serial.begin(9600);
  SPI.begin();
  SPI.setClockDivider(SPI_CLOCK_DIV2);
  
  adc.Init(AD7715::Normal,AD7715::Max,AD7715::FMax,AD7715::bi,AD7715::bufon,AD7715::syncon);
}

void loop() {

  adc.readdata();
  delay(1000);
}
