#1 - node a ser excluído não possui filhos.
#2 - node a ser excluído possui apenas 1 filho.
#3 - node a ser excluído possui 2 filhos.

no caso #3, o menor node da sub arvore da direita (do node que está sendo removido) pode ou não obter um filho. Este filho (se houver) obrigatoriamente precisa estar no sub node da direita, e neste caso este filho passa a ser referenciado pelo pai do menor node encontrado, e o menor node encontrado passa a substituir a posicão do node que está sendo removido. 


adicionar observação de que o método remove tem um pequeno possível erro de implementação. No cenário #3, quando ele encontra o menor valor da sub árvore da direita, ele não faz nenhuma atualização de referência dos nodes, mas apenas sobreescreve o valor do node que teoricamente deveria ser removido. Perguntar ao Teoi se é um problema trabalhar nesse formato de sobreposição, e não de atualização de referências dos nodes, como conceitualmente é feito.