# Desafios de programação.

## Algoritmos Simples

### 1. Criar uma aplicação que permita ao usuário entrar com a base e a altura de um retângulo e imprimir a seguinte saída:

* Perímetro
* Área 
* Diagonal

### 2. Criar um programa que leia uma temperatura em graus centígrados e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão é:
F=(9*C + 160)/5

Onde: 

F é a temperatura em Fahrenheit.

C é a temperatura em centígrados. 

### 3. Criar um programa que efetue o cálculo da quantidade de litros de combustível gastos em uma viagem, sabendo-se que o carro faz 12 km com um litro. Deverão ser fornecidos o tempo em horas gasto na viagem e a velocidade média em kilometros por hora. Utilizar as seguintes fórmulas: 

* Distância = tempo x velocidade. 
* Litros usados = distância / 12. 

### O programa deverá apresentar os valores da velocidade média, tempo gasto na viagem, distância percorrida e a quantidade de litros utilizados na viagem. 

## Decisão e Repetição

### 4. Criar um programa que solicite ao usuário um número e diga se o número é par ou impar.

### 5. Criar uma aplicação que leia dois valores para as variáveis A e B, efetuar a troca dos valores de forma que a variável A passe a ter o valor da variável B e a variável B passe a ter o valor da variável A. Apresentar os valores trocados.

### 6. Criar um programa que utilizando a estrutura FOR imprima uma sequencia de números de 0 a 100.

### 7. Criar um programa que utilizando uma estrutura FOR imprima todos os números impares de 0 a 10.

### 8. Criar uma aplicação console que peça ao usuário a altura de um triangulo, desenhe na tela o triangulo invertido, como abaixo:
```
Altura do Triangulo: 4

****
***
**
*
```

### 9. Escrever uma aplicação que leia um peso na Terra e o número de um planeta e imprima o valor do seu peso neste planeta. A relação de planetas é dada a seguir juntamente com o valor das gravidades relativas à Terra:

|   | Gravidade Relativa | Planeta  |
|---|--------------------|----------|
| 1 | 0,37               | Mercúrio |
| 2 | 0,88               | Vênus    |
| 3 | 0,38               | Marte    |
| 4 | 2,64               | Júpiter  |
| 5 | 1,15               | Saturno  |
| 6 | 1,17               | Urano    |

### Para calcular o peso no planeta use a fórmula: 
Pplaneta=(Pterra/10) * gravidade

### 10. Crie um programa que peça para o usuário entrar com um número e imprimir uma das mensagens: é multiplo de 3 ou não é multiplo de 3.

### 11. Criar uma aplicação que entre com dois nomes e imprimi-los em ordem alfabética.

### 12. Criar uma aplicação que entre com três números e imprimi-los em ordem crescente (suponha números diferentes).

### 13. Criar uma aplicação que peça para o usuário três números e verificar se eles podem ou não ser lados de um triângulo. Imprimir a classificação segundo os lados ou uma mesagem dizendo que os lados não fazem parte de um triângulo. Para ser um triângulo válido, o comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.

### 14. Crie um programa que permita ao usuário entrar com um verbo no infinitivo e imprimir uma das mensagens:
* Verbo não está no infinitivo.
* Verbo da 1ª- conjugação.
* Verbo da 2ª- conjugação.
* verbo da 3ª- conjugação.

### 15. Crie um programa que peça para o usuário um número inteiro entre 1 e 12 e escrever o mês correspondente. Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número. 

### 16. Um endocrinologista deseja controlar a saúde de seus pacientes e, para isso, se utiliza do Índice de Massa Corporal (IMC). Sabendo-se que o IMC é calculado através da seguinte fórmula:

IMC = peso / altura<sup>2</sup>

### Onde: 
- Peso é dado em Kg 
- Altura é dada em metros 
 
### Criar um programa que apresente o nome do paciente e sua faixa de risco, baseando-se na seguinte tabela:

| IMC                   | FAIXA DE RISCO    |
|-----------------------|-------------------|
| abaixo de 20          | abaixo do peso    | 
| a partir de 20 até 25 | normal            |
| acima de 25 até 30    | excesso de peso   | 
| acima de 30 até 35    | obesidade         |
| acime de 35           | obesidade mórbida |

### 17. Criar um programa que imprima os números de 120 a 300.

### 18. Criar uma aplicação que leia um número que será o limite superior de um intervalo e imprimir todos os números ímpares menores do que esse número.
Exemplo: 

Limite superior: 15  Impressão: 1,2,5,7,9,11,13

## Arrays e Coleções.

### 19. Criar um programa que dado um vetor de inteiros com N posições, determinadas pelo usuário, permita que usuário digite esses N números através de um prompt na console, listando os valores digitados.

### 20. Criar um programa que inicialize uma vetor de 10 inteiros com números aleatórios gerados com o método random e imprima duas listas, uma com os números pares outra com numeros impares.

### 21. Criar um programa que simule o uso de um caixa eletronico, onde o usuário pode entrar um valor, e o programa calcula o número de notas a serem entregues pelo dispositivo. O dispositivo deve minimizar o número de notas entregues para o usuário.

### 22. Criar um programa que dada uma matriz 3x3 de inteiros aleatórios, realize a soma de todos os números exibindo o total na tela.

### 23. Crie uma aplicalçao que crie um vetor de inteiros com 10 posições, as inicialize com números aleatórios, exiba a lista na tela e diga qual é a posição do maior e do menor número existente no array.

### 24. Crie uma aplicação que dados dois vetores de inteiro com 10 posições, gere um terceiro vetor contendo a o resultado da soma dos valores dos vetores inciais.

Exemplo:

A={1,2,3,4,5,6,7,8,9,0}

B={0,9,8,7,6,5,4,3,2,1}

C={1,11,11,11,11,11,11,11,11,1}

### 25. Criar uma aplicação que inicie dois vetores com o tamanho determinado pelo usuário, com números aleatórios, gere um tereceiro vetor que deve ser a união dos dois primeiros e exiba os três vetores na console.

### 26. Criar uma aplicação console, que permita ao usuário digite uma quantidade arbitrária de nomes, armazenando esses nomes em uma coleção. Ao fim da digitação, a aplicação deverá dizer a quantidade de nomes adicionados pelo usuário.

### 27.Crie um programa para criar uma agenda de aniversários. A agenda deve permitir ao usuário:
* Cadastar um nome e uma data de nascimento relacionada ao nome.
* Apagar um nome existente.
* Procurar por um nome na agenda, exibindo a data de aniversário relacionada caso o nome exista ou uma mensagem de erro, caso o contrário.
* Listar todos os nomes e aniversários contidos na agenda.

## POO.

### 28. Crie uma aplicação chamada AgendaTelefonica que implemente a seguinte classe:

| Registro                   |
|----------------------------|
| private string Nome        | 
| private string Telefone    |
| private string Aniversario |

### A classe teve ter um construtor que permita a passagem do nome, telefone e aniversario, os métodos de acesso para todos os atributos.
### A aplicação deve criar uma instância da classe registo e permitir que o usuário entre com os dados do registro.

### 29. Modifique a aplicação AgendaTelefonica para que ela permita uma quantidade arbritária de registros. Além disso a aplicação deverá ter a seguintes funcionalidades:

* Casdastro, Atualização e Remoção de Registos.
* Busca por nome.
* Busca por aniversário.
* Listagem dos registros.

