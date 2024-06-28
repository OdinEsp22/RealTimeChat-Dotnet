
using MediatR;

namespace UseCases.Interfaces;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IQuery<out TResponse> : IRequest<TResponse> { }

/// <summary>
/// 
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
 where TRequest : IQuery<TResponse> { }
