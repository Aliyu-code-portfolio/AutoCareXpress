using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Repositories
{
    internal sealed class PickUpAddress_Repository : RepositoryBase<PickUpAddress>, IPickUpAddress_Repository
    {
        public PickUpAddress_Repository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void DeletePickUpAddress(PickUpAddress pickUpAddress)
        {
            Delete(pickUpAddress);
        }

        public async Task<IEnumerable<PickUpAddress>> GetAllPickUpAddress(bool trackChanges)
        {
            var pickUpAddresses = await FindAll(trackChanges).ToListAsync();
            return pickUpAddresses;
        }

        //Please check this, I don't know how to do it becase i didnt see any foreign key pointing to userId in the "PickUpAddressModel. I also checked the diagram and there's no foreign key pointing to user table"
        public async Task<PickUpAddress> GetPickUpAddressByUserId(Guid userId, bool trackChanges)
        {
            var pickUpAddress = await FindByCondition(p => p.UserId.Equals(userId), trackChanges).FirstOrDefaultAsync();
            return pickUpAddress;
        }

        public void UpdatePickUpAddress(PickUpAddress pickUpAddress)
        {
            Update(pickUpAddress);
        }
    }
}
