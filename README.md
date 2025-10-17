# Pilha

Exercício: Sistema de Desfazer (Undo) de Editor de Texto

🎯**Objetivo**

Implementar uma estrutura de Pilha manualmente para simular o sistema de "Desfazer" (Undo) de um editor de texto.   
 O exercício tem como foco compreender o funcionamento de uma pilha (LIFO — Last In, First Out) e como empilhar e desempilhar elementos de forma manual.   
 
🧱 **Requisitos de Implementação**   
Crie uma classe chamada _Pilha_   
A pilha deve armazenar strings (cada operação ou texto digitado).

Deve possuir:   
Tamanho fixo (por exemplo, 10 posições).   
Um índice de topo (top) para controlar a posição atual.   

Métodos obrigatórios:    
Empilhar(string item): adiciona um item no topo da pilha.   
Desempilhar(): remove e retorna o item do topo da pilha.   
Topo(): retorna o item do topo sem removê-lo.   
EstaVazia(): retorna true se a pilha estiver vazia.   
EstaCheia(): retorna true se a pilha estiver cheia.   
ExibirPilha(): mostra o conteúdo da pilha (do topo até a base).  

Crie uma classe _EditorTexto_   
Deve conter um atributo do tipo Pilha, chamado historico.

Métodos obrigatórios:     
Digitar(string texto): adiciona o texto à pilha de histórico.   
Desfazer(): remove o último texto digitado (usando Desempilhar).   
MostrarHistorico(): exibe todo o histórico de textos.   

Na classe _Program_ (método Main)   
Crie um menu interativo com as seguintes opções:   
Digitar novo texto  
Desfazer última ação   
Mostrar histórico   
Sair (O programa deve rodar em loop até que o usuário escolha “Sair)
