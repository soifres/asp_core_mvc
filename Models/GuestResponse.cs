using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp_core_mvc.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста, введите свой адрес электронной почты")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста, введите свой номер телефона")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста, укажите примите ли вы участие")]        
        public bool? WillAttend { get; set; }
    }

    public static class Repository
    {
        private static List<GuestResponse> responses =
            new List<GuestResponse>();
        
        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse gr)
        {
            responses.Add(gr);
        }
    }
}