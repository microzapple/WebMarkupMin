﻿using Microsoft.Extensions.Options;

using WebMarkupMin.AspNet.Common;

namespace WebMarkupMin.AspNetCore1
{
	/// <summary>
	/// HTTP compression manager
	/// </summary>
	public sealed class HttpCompressionManager : HttpCompressionManagerBase
	{
		/// <summary>
		/// Constructs a instance of HTTP compression manager
		/// </summary>
		/// <param name="options">HTTP compression options</param>
		public HttpCompressionManager(IOptions<HttpCompressionOptions> options)
		{
			CompressorFactories = options.Value.CompressorFactories;
		}
	}
}