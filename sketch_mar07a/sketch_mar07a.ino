int led=10;
void setup() {
 Serial.begin(9600);
 pinMode(led,OUTPUT);
}

void loop() {
  if(Serial.available()){
      int gelenveri=Serial.read();

      if(gelenveri=='1'){
            digitalWrite(led,HIGH);
        }
      else if(gelenveri=='0'){
            digitalWrite(led,LOW);
        }
    
    
    }
}
