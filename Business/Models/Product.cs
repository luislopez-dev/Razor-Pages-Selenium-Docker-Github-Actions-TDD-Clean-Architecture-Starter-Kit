/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using System.Collections;

namespace Business.Models;

public class Product
{
    public int Id { get; set; }
    public Guid Guid { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }

    public List<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
}

/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
