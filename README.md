# API de uma Loja Online    
    API de Produtos, do Estoque de uma Loja, e de Vendas. 
# Projeto
    API que tem por objetivo fornecer serviços os produtos que estão cadastrados no banco de dados, seu estoque e realizar vendas desses produtos.
# End-Points
    * /produto - lista de todos os produtos
        - /create - recebe os atributos dos produtos e cadastra um novo produto na API.
        - /update/{id} - atualiza as informações do produto que possui id.
        - /delete/{id} - excluir o produto de id.
        - /view/{id} - exibir as informações do produto especifico.
    * /entrada - lista todas as entradas cadastradas na API
        - /create - recebe os atributos dos entrada e cadastra um nova entrada do produto na API.
        - /update/{id} - atualiza as informações da entrada que possui id.
        - /delete/{id} - excluir o entrada de id.
        - /view/{id} - exibir as informações da entrada.
    * /vendas - lista todas as vendas realizadas 
        - /create - cria uma nova venda.
        - /update/{id} - atualiza as informações de uma venda que possui id.
        - /delete/{id} - excluir a venda de id.
        - /view/{id} - exibir as informações da venda.
# Tecnologias  
    - .NET
    - MVC
    - API RestFull
    - Autenticação JWT
    - SQL Server
