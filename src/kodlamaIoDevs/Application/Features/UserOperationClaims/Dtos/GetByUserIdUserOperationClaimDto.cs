﻿namespace Application.Features.UserOperationClaims.Dtos
{
    public class GetByUserIdUserOperationClaimDto
    {
        public int Id { get; set; }
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }
    }
}
