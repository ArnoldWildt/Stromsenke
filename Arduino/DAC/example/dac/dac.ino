#include <SPI.h>
#include <DAC.h>

DAC dac(10);



void setup() {
  Serial.begin(9600);
  SPI.begin();
  SPI.setClockDivider(SPI_CLOCK_DIV2);
  dac.write(256);
}

void loop() {
  //dac.write(1000);
  //delay(1000);

}
