using System;


namespace GameStore.WebUI.Models
{
    public class PagingInfo
    {
        // Кол-во товаров
        public int TotalItems { get; set; }
        // Кол-во товаров на одной странице
        public int ItemsPerRage { get; set; }
        // Номер текущей страницы
        public int CurrentPage { get; set; }
        // Общее кол-во страниц
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerRage); }
        }
    }
}