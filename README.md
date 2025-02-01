SendEmailApi - API para Envio de E-mails

Este projeto é uma API desenvolvida em C# utilizando ASP.NET Core para envio de e-mails via SMTP.

📌 Tecnologias Utilizadas

Linguagem: C#

Framework: ASP.NET Core

Bibliotecas: System.Net.Mail

🚀 Como Executar o Projeto

🛠 Pré-requisitos

.NET SDK instalado.

Um servidor SMTP válido (exemplo: Gmail, Yahoo, Outlook, etc.).

📥 Clonar o Repositório

git clone https://github.com/mewtoex/SendEmail.git
cd SendEmail

▶️ Executando a API

Abra o projeto em uma IDE compatível (Visual Studio, Rider ou VS Code com extensão C#).

Configure as credenciais de e-mail no código (substitua os valores corretos para login, password e lSmtpServer).

No terminal, execute o seguinte comando:

dotnet run

A API estará disponível em http://localhost:5000 (ou conforme configuração).

📨 Como Usar a API

A API possui um endpoint que recebe uma solicitação POST para enviar e-mails:

POST /api/Recevi

Parâmetro: emailSend (string) - Endereço de e-mail do destinatário.

Exemplo de Requisição

{
  "emailSend": "exemplo@email.com"
}

Exemplo de Resposta

true  // Indica que o e-mail foi enviado com sucesso

📂 Estrutura do Projeto

/
├── SendEmailApi/           # Código-fonte da API
│   ├── Controllers/        # Controladores da API
│   │   ├── toReceiveRequest.cs  # Endpoint para envio de e-mails
│   ├── Util/               # Utilitários
│   │   ├── util.cs         # Lógica para envio de e-mails
│   ├── Program.cs          # Configuração principal do ASP.NET Core
├── SendEmailApi.sln        # Solução do projeto
└── README.md               # Documentação

⚠️ Considerações Importantes

O envio de e-mails depende das configurações do servidor SMTP utilizado.

Caso esteja usando Gmail, ative a opção "Permitir aplicativos menos seguros" ou configure OAuth2.

A classe SmtpClient está obsoleta no .NET moderno. Recomenda-se migrar para o MailKit.

📌 Melhorias Futuras

Substituir SmtpClient por MailKit para maior compatibilidade.

Implementar logs para facilitar a depuração.

Criar suporte para envio de anexos.

✍️ Autor

Whanderson (mewtoex) - GitHub

Este projeto demonstra o uso de ASP.NET Core para criação de APIs e envio de e-mails via SMTP. 🚀

