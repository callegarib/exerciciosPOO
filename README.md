# Exercícios - Programação Orientada a Objeto.

1. Crie um projeto para resolver a sequência de Fibonacci 1,1,2,3,5,8,13,21 .... deve pedir o valor a ser calculado.

2. Converter temperatura: deve solicitar a temperatura em celsius e dar a conversão em kelvin e fahrenheit.

3. Calculo de frete para uma compra: 
	• Vamos criar um programa que receba a distância entre o distribuidor e o local de entrega e calcule o valor do frete, sendo que para km é cobrado R$0,10
	• A cada 200 km, deve adicionar uma taxa de R$ 1,00
	• A cada 1000 km, deve adicionar uma taxa de R$ 10,00
	• Agora precisamos calcular o frete baseado no preço da encomenda:
		○ O valor do frete não altera para produtos com até 5kg
		○ Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
		○ Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x
4.Exercício: Dispositivos Eletrônicos:
• Crie uma hierarquia de classes/interfaces para representar diferentes tipos de dispositivos eletrônicos ( Celular, cafeteira, geladeira ...). Cada dispositivo deve ter
métodos para ligar, desligar e exibir informações sobre seu status.
	• IDispositivoEletronico (Interface):
		○ Métodos:
		○ Ligar(): Liga o dispositivo.
		○ Desligar(): Desliga o dispositivo.				
		○ ObterStatus(): Retorna uma mensagem indicando o status do dispositivo (ligado/desligado).

5. Vamos criar um software em que inicialmente não seguimos o princípio Open/Closed (OCP). Temos alguns carros e devemos calcular o preço de aluguel de acordo com o tipo de carro.

6. Vamos criar um software em que inicialmente não seguimos o princípio LISKOV (LSP). Temos um guarda chuva comum e outro automático, vamos implementar como eles devem abrir.

7. Vamos criar um programa que é responsável por armazenar informações de um produto e calcular o preço do produto baseado em diferentes descobtos. Aplicar os princípios do SRP.
	• Agora queremos mostrar os produtos que tem na loja. Após crie um novo método para Trazer todos os Produtos: public Produtos[] TragaTodosOsProdutos(), e use esta implementação no MostrarProdutos()