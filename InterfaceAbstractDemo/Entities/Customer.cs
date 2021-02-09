using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public DateTime Birth { get; set; }
        public string NationalityId { get; set; }
    }
}
