Mostra como fazer alguns cálculos financeiros como o Percentage Of Volume POV

Participate ou Percent of Volume (PoV)
O PoV é uma estratégia onde o algoritmo segue a variação de volume do mercado num percentual predefinido pelo operador. Por exemplo, digamos que o operador decida que o algoritmo deve seguir o mercado num volume de 10%. Nesse caso o algoritmo sempre vai procurar bater somente 10% do volume de negociações. O PoV acompanha a variação do volume do mercado, de forma mais precisa do que o VWAP.

O maior problema dessa estratégia é do algoritmo receber, do operador, o percentual do volume do mercado errado, podendo encerrar suas ordens antes de acabar o dia, correndo risco de perder oportunidades fora do tempo que ele ficou ativo.

Representação simples da estratégia PoV, podendo durar o período completo de um dia se assim o operador decidir

A estratégia Percentage of Volume (POV) é utilizada quando o cliente quer executar uma quantidade que acompanhe um determinado percentual do volume negociado de um papel no mercado.
Por exemplo, o cliente quer fazer 10% do volume do papel PETR4. Ao serem negociadas 1000 ações no total do papel no mercado, é esperado que 100 ações desse total tenham sido executadas por essa estratégia.
A função abaixo com a porcentagem e o número de ações negociadas informados, retorna o valor de ações que devem ser negociadas pela estratégia POV para atingir o volume esperado.

Considere:
decimal FuncaoRetornaQuantidade (decimal porcentagem, int totalNegociado)
FuncaoRetornaQuantidade (0.1, 900) = 100.

Ou seja, quando a função receber um totalNegociado no mercado de 900 ações e o percentual definido pelo cliente for 10%, a estratégia terá de executar 100 ações para totalizar 1000 ações negociadas no mercado.

decimal FuncaoRetornaQuantidade(decimal porcentagem, int totalNegociado)
{
  return (int)(totalNegociado * porcentagem)/((1 - porcentagem));
}

Console.Write(FuncaoRetornaQuantidade((decimal)0.1, 900));
