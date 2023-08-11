using N23_T1.Services;

var service = new RegistrationService();
service.Register("test@gmail.com", "234567");
service.Register("testB@gmail.com", "234567");
service.Register("testC@gmail.com", "234567");

service.Register("test@gmail.com", "234567");
