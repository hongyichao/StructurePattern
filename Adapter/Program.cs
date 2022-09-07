// See https://aka.ms/new-console-template for more information
using Adapter;


EmailClient client = new EmailClient();

client.addProvider(new GmailProvider());
client.addProvider(new MyEmailProvider());

client.downloadEmails();