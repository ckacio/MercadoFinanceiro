using MercadoFinanceiro;

/*
 * Considere:  
 * decimal FuncaoRetornaQuantidade (decimal porcentagem, int totalNegociado) 
 * FuncaoRetornaQuantidade (0.1, 900) = 100.
 * Ou seja, quando a função receber um totalNegociado no mercado de 900 ações 
 * e o percentual definido pelo cliente for 10%, a estratégia terá de executar 100 ações 
 * para totalizar 1000 ações negociadas no mercado.
 */
Console.Write(PercentageOfVolumePOV.FuncaoRetornaQuantidade((decimal)0.1, 900));
