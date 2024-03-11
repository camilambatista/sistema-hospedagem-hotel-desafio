
using Models;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Hóspede 1");
Pessoa p2 = new Pessoa(nome:"Hóspede 2", sobrenome:"Sobrenome 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite:"Premium", capacidade:2, valorDiaria:30);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados:10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
System.Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
