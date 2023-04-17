Algoritmo "semnome"

Var

a: vetor[1..9] de inteiro
x, razao:inteiro

Inicio

escreval("Digite o valor de a1, a2 e a3")
para x de 1 ate 3 passo 1 faca
     leia(a[x])
fimpara

razao <- a[2] - a[1]

escreval("== P.A ==")
escreval("razao =", razao)

para x de 2 ate 9 passo 1 faca
     a[x] <- a[x-1] + razao
     escreval("a[",x," ]= ",a[x])
fimpara

Fimalgoritmo