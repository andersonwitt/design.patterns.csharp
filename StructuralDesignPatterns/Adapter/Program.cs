using Adapter;

var car = new Car();

AutoMobile autoMobile = new AutoMobile(car);

autoMobile.Run();

autoMobile.Stop();

// ou posso trocar livremente entre adapter e car sem alterar a logica do automobile

CarAdapter adapter = new CarAdapter(car);

AutoMobile autoMobile1 = new AutoMobile(adapter);

autoMobile1.Run();

autoMobile1.Stop();