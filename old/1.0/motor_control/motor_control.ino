
#include <Adafruit_NeoPixel.h>
#include <EEPROMex.h>

// The following is a simple stepper motor control procedures
# define ENDSTOPH 2 // x+ endstop
# define ENDSTOPL 3 // x- endstop
# define XEN 38 // stepper motor enable , active low
# define X_DIR 55 // x -axis stepper motor direction control
# define X_STP 54 // x -axis stepper control
# define Z1EN 56 // stepper motor enable , active low
# define Z2EN 62 // stepper motor enable , active low
# define Z1_STP 60 //z -axis stepper contro
# define Z2_STP 46 //z -axis stepper contro
# define Z1_DIR 61 //z -axis stepper motor direction control
# define Z2_DIR 48 //z -axis stepper motor direction control
#define LED_PIN 52 // top Led control
#define LED_COUNT 56 //nr led top
#define LAMP 9


//initialize neopixel strips
Adafruit_NeoPixel strip_top(LED_COUNT, LED_PIN, NEO_RGBW + NEO_KHZ800);    

//initialize variables
int no_steps;
const byte numChars = 32;
char receivedChars[numChars];   // an array to store the received data
boolean newData = false;
int dataNumber = 0;             // new for this version
long pulse;
int Home;
int Xpos;
int EEPROMaddress = 0 ;

// change brightness ( white only) of top and bottom led strips
void LED_top(int brightness) {
  strip_top.fill(strip_top.Color(0,0,0,brightness));
  strip_top.show();
  Serial.println("Done");
}

void LED_bottom(int brightness) {
  if (brightness>0) {
    digitalWrite (LAMP, HIGH);
  }
  else{
    digitalWrite (LAMP, LOW);
  }
  Serial.println("Done");
}

//move table in direction X by Y steps
void step (int no_steps){
  digitalWrite (XEN, LOW);
  if (no_steps > 0){
    digitalWrite(X_DIR, true);
  }
  else{
    digitalWrite(X_DIR, false);
  }
  
    delay (50);

    Xpos=Xpos + no_steps;
    pulse=abs(no_steps);
    pulse=pulse*200;

    for (long i = 0; i < pulse; i++) {
      if(endstop()){
        digitalWrite (X_STP, HIGH);
        delayMicroseconds (200);
        digitalWrite (X_STP, LOW);
        delayMicroseconds (200);
      }
      else {
        Serial.println("Endstop");
        //break;
        return;
      }
    }
  digitalWrite (XEN, HIGH);
  Serial.println("Done");
}

//move camera in direction X by Y steps
void movez(int no_steps, int multi){
  digitalWrite (Z1EN, LOW);
  digitalWrite (Z2EN, LOW);
  if (no_steps > 0){
      digitalWrite(Z1_DIR, true);
      digitalWrite(Z2_DIR, true);
  }
  else{
      digitalWrite(Z1_DIR, false);
      digitalWrite(Z2_DIR, false);
  }

    delay (50);
    for (int i = 0; i < (abs(no_steps)*multi); i++) 
    {
        digitalWrite (Z1_STP, HIGH);
        digitalWrite (Z2_STP, HIGH);
        delayMicroseconds (200);
        digitalWrite (Z1_STP, LOW);
        digitalWrite (Z2_STP, LOW);
        delayMicroseconds (200);
    }
  digitalWrite (Z1EN, HIGH);  
  digitalWrite (Z2EN, HIGH);
  Serial.println("Done");
}

//go back all the way until home or endstop
void gohome(){
  digitalWrite (XEN, LOW); //enable shield
  pulse=Home-Xpos;
  Xpos=Xpos + pulse;
  if (pulse > 0){
    digitalWrite(X_DIR, true);
  }
  else{
    digitalWrite(X_DIR, false);
  }
  pulse=abs(pulse);
  pulse=pulse*200;
  //pulse=(Home-Xpos)*200;
  delay (50);
  for (long i = 0; i < pulse; i++) {
    if(endstop()){
      digitalWrite (X_STP, HIGH);
      delayMicroseconds (200);
      digitalWrite (X_STP, LOW);
      delayMicroseconds (200);
    }
    else {
      Serial.println("Endstop");
      //break;
      return;
    }
  
  }
  Serial.println("Done");
}

void logout(){
  LED_top(0);
  digitalWrite (LAMP, LOW);
  gohome();
  Serial.println("Done");
}

void set(){
  Home=Xpos;
  EEPROM.writeInt(EEPROMaddress, Xpos);
  Serial.println("Done");
}

void getx(){
  Serial.println(Xpos);
  Serial.println("Done");
}

bool endstop(){
  if((!digitalRead(ENDSTOPH) || !digitalRead(ENDSTOPL))==false){
  return true;
  }
  else if(digitalRead(ENDSTOPL)==false){
      digitalWrite(X_DIR, true); // go forward
      delay (50);
      for (int i = 0; i < 200; i++){
          digitalWrite (X_STP, HIGH);
          delayMicroseconds (200);
          digitalWrite (X_STP, LOW);
          delayMicroseconds (200);
        }
     Serial.println("Stop");
     return false;
  }
  else if(digitalRead(ENDSTOPH)==false){
      digitalWrite(X_DIR, false); // go back
      delay (50);
      for (int i = 0; i < 200; i++){
          digitalWrite (X_STP, HIGH);
          delayMicroseconds (200);
          digitalWrite (X_STP, LOW);
          delayMicroseconds (200);
        }
      Serial.println("Stop");
      return false;
  }
}

void cal(){
  digitalWrite (XEN, LOW); //enable shield
  digitalWrite(X_DIR, false); // go backwards
  delay (50);
  while ((digitalRead(ENDSTOPL))==true){
        digitalWrite (X_STP, HIGH);
        delayMicroseconds (200);
        digitalWrite (X_STP, LOW);
        delayMicroseconds (200);
      }
  digitalWrite(X_DIR, true); // go forward
  delay (50);
  for (int i = 0; i < 200; i++){
      digitalWrite (X_STP, HIGH);
      delayMicroseconds (200);
      digitalWrite (X_STP, LOW);
      delayMicroseconds (200);
    }
  digitalWrite (XEN, HIGH); //disable shield
  Xpos=0;
  Serial.println("Done");
}

// initialize 
void setup () {   
    Serial.begin(9600);
    
    //Initalize pins
    pinMode (X_DIR, OUTPUT); 
    pinMode (X_STP, OUTPUT);
    
    pinMode (Z1_DIR, OUTPUT); 
    pinMode (Z1_STP, OUTPUT);
    
    pinMode (Z2_DIR, OUTPUT); 
    pinMode (Z2_STP, OUTPUT);
    
    pinMode (XEN, OUTPUT);
    pinMode (Z1EN, OUTPUT);
    pinMode (Z2EN, OUTPUT);
    pinMode (ENDSTOPH, INPUT);
    pinMode (ENDSTOPL, INPUT);
    pinMode (LAMP, OUTPUT);

    //disable CNC Shield
    digitalWrite (XEN, HIGH);
    digitalWrite (Z1EN, HIGH);
    digitalWrite (Z2EN, HIGH);
    

    strip_top.begin();           // INITIALIZE NeoPixel strip object
    strip_top.show();            // Turn OFF all pixels ASAP
    LED_top(0);
    digitalWrite (LAMP, LOW); // switch lamp off 

    
   Home=EEPROM.readInt(EEPROMaddress); // read home position from eeprom
   Xpos=Home;
    
}

//read serial
void recvWithEndMarker() {
    static byte ndx = 0;
    char endMarker = '\n';
    char rc;
   
    if (Serial.available() > 0) {
        rc = Serial.read();

        if (rc != endMarker) {
            receivedChars[ndx] = rc;
            ndx++;
            if (ndx >= numChars) {
                ndx = numChars - 1;
            }
        }

        else {
            receivedChars[ndx] = '\0'; // terminate the string
            ndx = 0;
            newData = true;
        }
    } 
}

//get instruction from serial
void showNewNumber() {
    if (newData == true) {
        if(strstr(receivedChars,"Arduino?")!=NULL){
          Serial.println("Arduino!");
          newData = false;
          }
          else if(strstr(receivedChars,"Home")!=NULL){
          Serial.println("ACK");
          newData = false;
          gohome();//go back until home
          }
          else if(strstr(receivedChars,"Logout")!=NULL){
          Serial.println("ACK");
          newData = false;
          logout();// set light to zero and go home
          }
          else if(strstr(receivedChars,"Cal")!=NULL){
          Serial.println("ACK");
          newData = false;
          cal();//calibrate x axis go all the way back and set to 0
          }
          else if(strstr(receivedChars,"Getx")!=NULL){
          Serial.println("ACK");
          newData = false;
          getx();// get current x position
          }
          else if(strstr(receivedChars,"Set")!=NULL){
          Serial.println("ACK");
          newData = false;
          set();//save new home
          }
          else if(strstr(receivedChars,"Height")!=NULL){
          dataNumber = 0;           
          dataNumber = atoi(receivedChars+6);
          Serial.println("ACK");
          newData = false;
          movez(dataNumber,800); //move height in mm
          }
          else if(strstr(receivedChars,"M")!=NULL){
          dataNumber = 0;             
          dataNumber = atoi(receivedChars+6);
          Serial.println("ACK");
          newData = false;
          movez(dataNumber,80); //move height in 0.1mm
          }
          else if(strstr(receivedChars,"MM")!=NULL){
          dataNumber = 0;            
          dataNumber = atoi(receivedChars+6);
          Serial.println("ACK");
          newData = false;
          movez(dataNumber,8); //move height in 0.01mm
          }
          else if(strstr(receivedChars,"LEDT")!=NULL){
          dataNumber = 0;            
          dataNumber = atoi(receivedChars+4);
          Serial.println("ACK");
          newData = false;          
          LED_top(dataNumber); // set intensity for top led light
          }
          else if(strstr(receivedChars,"LEDB")!=NULL){
          dataNumber = 0;             // new for this version
          dataNumber = atoi(receivedChars+4);
          Serial.println("ACK");
          newData = false;
          LED_bottom(dataNumber); //switches bottlom light on or off
          }
          else {
              dataNumber = 0;             // new for this version
              dataNumber = atoi(receivedChars);   // new for this version
              Serial.println("ACK");
              newData = false;
              step(dataNumber); //moxe x axis in mm
          }
    }
}

//main function
void loop () {
    recvWithEndMarker();
    showNewNumber();


    
} 
