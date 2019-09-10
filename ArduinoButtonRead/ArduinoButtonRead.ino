int botaoA = 12;
int sensorLuz = A0;

void setup() {
  pinMode(botaoA, INPUT);
  pinMode(sensorLuz, INPUT);
  
  Serial.begin(9600);
}

void loop() {
  bool leituraBotaoA = digitalRead(botaoA);
  int leituraSensorLuz = analogRead(sensorLuz);
  
  Serial.print(leituraBotaoA);
  Serial.print(";");
  Serial.print(leituraBotaoA);
  Serial.print(";");
  Serial.print(leituraBotaoA);
  Serial.print(";");
  Serial.print(leituraBotaoA);
  Serial.print(";");
  Serial.println(leituraSensorLuz);

  delay(50);
}
