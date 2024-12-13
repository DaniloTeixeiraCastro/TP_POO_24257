using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    internal class PaymentService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\payments.json";
        private static List<Payment> paymentList = new List<Payment>();

        // Construtor estático para carregar pagamentos do JSON
        static PaymentService()
        {
            if (File.Exists(FilePath))
            {
                paymentList = LoadPaymentsFromJson();
            }
        }

        /// <summary>
        /// Adiciona um novo pagamento.
        /// </summary>
        public static string AddPayment(Payment payment)
        {
            payment.PaymentId = paymentList.Count > 0 ? paymentList.Max(p => p.PaymentId) + 1 : 1;
            paymentList.Add(payment);
            SavePaymentsToJson();
            return "Pagamento realizado com sucesso!";
        }

        /// <summary>
        /// Lista todos os pagamentos.
        /// </summary>
        public static List<Payment> GetPayments()
        {
            return paymentList;
        }

        /// <summary>
        /// Remove um pagamento pelo ID.
        /// </summary>
        public static string RemovePayment(int paymentId)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment == null)
            {
                return "Pagamento não encontrado.";
            }

            paymentList.Remove(payment);
            SavePaymentsToJson();
            return "Pagamento removido com sucesso!";
        }

        /// <summary>
        /// Edita os detalhes de um pagamento.
        /// </summary>
        public static string EditPayment(Payment updatedPayment)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == updatedPayment.PaymentId);
            if (payment == null)
            {
                return "Pagamento não encontrado.";
            }

            payment.Reservation = updatedPayment.Reservation;
            payment.Amount = updatedPayment.Amount;
            payment.PaymentDate = updatedPayment.PaymentDate;
            payment.Status = updatedPayment.Status;

            SavePaymentsToJson();
            return "Pagamento editado com sucesso!";
        }

        /// <summary>
        /// Salva a lista de pagamentos no arquivo JSON.
        /// </summary>
        private static void SavePaymentsToJson()
        {
            var jsonData = JsonSerializer.Serialize(paymentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }

        /// <summary>
        /// Carrega a lista de pagamentos do arquivo JSON.
        /// </summary>
        private static List<Payment> LoadPaymentsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Payment>>(jsonData) ?? new List<Payment>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os pagamentos: {ex.Message}");
                return new List<Payment>();
            }
        }
    }
}
