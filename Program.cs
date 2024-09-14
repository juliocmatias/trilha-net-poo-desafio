using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new(numero: "987654321", modelo: "x", imei: "987654321", memoria: 1000);
Nokia nokia = new(numero: "987654321", modelo: "x", imei: "987654321", memoria: 1000);
iphone.InstalarAplicativo(nomeApp: "Instagram");
nokia.InstalarAplicativo(nomeApp: "WhatsApp");