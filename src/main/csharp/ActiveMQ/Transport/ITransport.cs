/*
 * Copyright 2006 The Apache Software Foundation or its licensors, as
 * applicable.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using ActiveMQ.Commands;
using NMS;
using System;

namespace ActiveMQ.Transport
{
	public delegate void CommandHandler(ITransport sender, Command command);
	public delegate void ExceptionHandler(ITransport sender, Exception command);

	/// <summary>
	/// Represents the logical networking transport layer.
	/// </summary>
	public interface ITransport : IStartable, IDisposable
    {
        void Oneway(Command command);
        
        FutureResponse AsyncRequest(Command command);
        
        Response Request(Command command);
        
        CommandHandler Command {
            get;
            set;
        }
		
        ExceptionHandler Exception {
            get;
            set;
        }
    }
}

