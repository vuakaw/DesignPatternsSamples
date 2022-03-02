// See https://aka.ms/new-console-template for more information


using BuilderDesignPattern.Entities;
using BuilderDesignPattern.Services;

ClassCharacterBuilder builder;

Game game = new Game();

builder = new DemonHunterBuilder();
game.Construct(builder);
builder.ClassCharacter.Show();
builder = new PaladinBuilder();
game.Construct(builder);
builder.ClassCharacter.Show();
builder = new WitchDoctorBuilder();
game.Construct(builder);
builder.ClassCharacter.Show();

Console.ReadKey();
