using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    //um fato ou uma verdade deve ser sempre verdadeira
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange - MONTAR O CENARIO
        var texto = "TikTok";
        var resultadoEsperado = 6;

        // Act - EXECUTA O CENARIO
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert - VALIDAÇÃO DO CENARIO
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var resultado =  _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
