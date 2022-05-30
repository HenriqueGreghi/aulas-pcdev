using AulasPCDev.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AulasPCDev.Unit.Test
{
    public class ContaTeste
    {
        [Fact]
        public void DeveAdicionarSaldoInicial()
        {
            int valor = 50;
            Conta contaASerTestada = new Conta(valor);

            int saldoDaConta = contaASerTestada.Saldo;
            Assert.True(saldoDaConta == valor);
        }

        [Theory]
        [InlineData(0, 100, 100)]
        [InlineData(50, 50, 100)]
        [InlineData(-50, 100, 50)]
        [InlineData(100, 1, 101)]
        public void DepositoDeveAdicionarSaldo(
            int valorInicial,
            int valorDeposito,
            int resultadoEsperado)
        {

            Conta conta = new Conta(valorInicial);
            conta.Deposito(valorDeposito);

            int resultado = conta.Saldo;
            Assert.True(resultado == resultadoEsperado);
        }
    }
}
