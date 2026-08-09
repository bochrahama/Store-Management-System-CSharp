using Microsoft.Identity.Client;
using System;
using System.Data;
namespace StoreManagementSystem.Operations
{
    //
    public enum ReportType
    {
        daily, weekly, monthly, yearly
    }
    //report class to generate reports for the store management system
    public class Report
    {

        public int ReportId { get; set; }
        public string ReportDescription { get; set; } = string.Empty;
        public ReportType ReportType { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalProfit { get; set; }
        public string BestSellingProduct { get; set; } = string.Empty;

        //method to generate report

        public string GenerateDailyReport()
        {
            // Logic to generate daily report
            if(StartData.Date != EndData.Date)
            {
                throw new ArgumentException("Start date and end date must be the same for a daily report.");
            }
            TotalProfit = TotalRevenue - TotalExpenses;
            var report = $"Daily Report for {StartData:yyyy-MM-dd}\n" +
                         $"Total Revenue: {TotalRevenue:C}\n" +
                         $"Total Expenses: {TotalExpenses:C}\n" +
                         $"Total Profit: {TotalProfit:C}\n" +
                         $"Best Selling Product: {BestSellingProduct}";
            return report;


        }
        public string  GenerateWeeklyReport()
        {
            // Logic to generate weekly report
            if ((EndData - StartData).TotalDays != 6)
            {
                throw new ArgumentException("Start date and end date must be 7 days apart for a weekly report.");
            }
            TotalProfit = TotalRevenue - TotalExpenses;
            var report = $"Weekly Report from {StartData:yyyy-MM-dd} to {EndData:yyyy-MM-dd}\n" +
                         $"Total Revenue: {TotalRevenue:C}\n" +
                         $"Total Expenses: {TotalExpenses:C}\n" +
                         $"Total Profit: {TotalProfit:C}\n" +
                         $"Best Selling Product: {BestSellingProduct}";
            return report;
        }
        public string  GenerateMonthlyReport()
        {
            // Logic to generate monthly report
            if (StartData.Month != EndData.Month || StartData.Year != EndData.Year)
            {
                throw new ArgumentException("Start date and end date must be in the same month and year for a monthly report.");
            }
            TotalProfit = TotalRevenue - TotalExpenses;
            var report = $"Monthly Report for {StartData:MMMM yyyy}\n" +
                         $"Total Revenue: {TotalRevenue:C}\n" +
                         $"Total Expenses: {TotalExpenses:C}\n" +
                         $"Total Profit: {TotalProfit:C}\n" +
                         $"Best Selling Product: {BestSellingProduct}";
            return report;
        }
        public string GenerateYearlyReport()
        {
            // Logic to generate yearly report
            if (StartData.Year != EndData.Year)
            {
                throw new ArgumentException("Start date and end date must be in the same year for a yearly report.");
            }
            TotalProfit = TotalRevenue - TotalExpenses;
            var report = $"Yearly Report for {StartData:yyyy}\n" +
                         $"Total Revenue: {TotalRevenue:C}\n" +
                         $"Total Expenses: {TotalExpenses:C}\n" +
                         $"Total Profit: {TotalProfit:C}\n" +
                         $"Best Selling Product: {BestSellingProduct}";
            return report;
        }


    }
}