# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Resposta

Na Classe Smartphone foram implementado as propriedades de acordo com o diagrama proposto do desafio, assim como ser passados os parâmetros para o seu construtor

Foi implementada também validação na propriedade Memória.

Para me desafiar implementei o método PegarAplicativos, para ler o arquivo "list_apps.json" da pasta "database", para que de acordo com dispositivo seja retornado uma lista de aplicativo já pre-estabelecido.

Foram implementadas as classes na pastas models: App, Dispositivo, além das já criadas Iphone, Nokia e Smartphone. 

- App:
  - Criada como modelo para representar um objeto app quando feita a DeserializeObject.

- Dispositivo 
    - Modelo para representar o objeto retornado pelo arquivo "list_apps.json", com os dispositivos e suas respectiva lista de aplicativo quando feita a DeserializeObject.

- Nokia:
    - Classe que herda de Smartphone e reescreve o método InstalarAplicativo de acordo com sua especificação.
    - no construtor foi chamado o método: PegarAplicativos, assim populando à lista de aplicativo para seu modelo especifico;

- Iphone:
    - Classe que herda de Smartphone e reescreve o método InstalarAplicativo de acordo com sua especificação.
    - no construtor foi chamado o método: PegarAplicativos, assim populando à lista de aplicativo para seu modelo especifico;
