﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestArch.Shared;

namespace TestArch.Domain.UseCases
{
    internal sealed class TestUseCase :
        IRequestHandler<TestCommand, string>
    {
        private readonly ITestRepo _repo;

        public TestUseCase(ITestRepo repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(
            TestCommand request,
            CancellationToken token)
        {
            return await _repo.Mod(
                request.Value,
                token);
        }
    }
}