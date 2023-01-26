using Bridge;

SedanElectric sedan = new SedanElectric();
SUVGasoline suv = new SUVGasoline();

sedan.TurnOn();
sedan.Accelerate();
sedan.TurnOff();

suv.TurnOn();
suv.Accelerate();
suv.TurnOff();