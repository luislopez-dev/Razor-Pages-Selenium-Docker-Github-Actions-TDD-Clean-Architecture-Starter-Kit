/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using System.ComponentModel.DataAnnotations;

namespace Business.Models;

public class InvoiceProduct
{
    public int Id { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Required]
    public int InvoiceId { get; set; }
    public Invoice Invoice { get; set; }
}