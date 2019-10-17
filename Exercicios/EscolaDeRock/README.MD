# EscolaDeRock

## Descrição

A aplicação EscolaDeRock tem como finalidade demonstrar diversos conceitos da 
programação orientada a objetos como:
1. Herança
2. Interfaces
3. Enumeradores

A aplicação console, cria 7 objetos representando os instrumentos musicais:
* Baixo
* Bateria
* Contrabaixo
* Guitarra
* Tambores
* Teclado
* Violão

Todas elas hedando da mesma classe base chamada InstrumentoMusical.

Além disso a aplicação define 3 interfaces:
+ IHarmonia
+ IMelodia
+ IPercussao

Que representam os grupos de instrumentos musicais existentes dentro de uma 
banda de música. A implementação das interfaces pelas classes devem seguir 
a seguinte regra:

| Interface      | Classes                                             |
|----------------|-----------------------------------------------------|
| **IHarmonia**  |Baixo, Contrabaixo, Guitarra, Teclado, Violão        |
| **IMelodia**   |Guitarra, Teclado, Violão                            |
| **IPercursao** |Baixo, Bateria,Contrabaixo, Tambores, Teclado, Violão|

## Diagramas de Classes

### Interfaces
| IHarmonia           |
|---------------------|
|                     |
| bool TocarAcordes() |

| IMelodia            |
|---------------------|
|                     |
| bool TocarSolo()    |

| IPercussao          |
|---------------------|
|                     |
| bool ManterRitmo()  |

### Classes
| InstrumentoMusical          |
|-----------------------------|
| string[] notas              |
|-----------------------------|
| public string TocarMusica() |

|    Baixo    |
|-------------|
|             |
|             |

|   Bateria   |
|-------------|
|             |
|             |

| Contrabaixo |		
|-------------|		
|             |				
|             |		

|   Guitarra  |
|-------------|
|             |
|             |

|  Tambores   |	
|-------------|	
|             |	

|   Teclado   |		
|-------------|		
|             |						

|    Violão   |
|-------------|
|             |
|             |