﻿/*
 * Author: ByronP
 * Date: 4/17/2018
 * Mod: 01/30/2019
 * Coinigy Inc. Coinigy.com
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace PureWebSockets
{
    public class PureWebSocketOptions : IPureWebSocketOptions
    {
        /// <inheritdoc />
        /// <summary>
        /// Headers including cookies to include in the connection.
        /// Use with caution as some headers can cause issues/failures in the framework.
        /// </summary>
        public IEnumerable<Tuple<string, string>> Headers { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Supported protocols
        /// </summary>
        public IEnumerable<string> SubProtocols { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// A proxy instance to use if required.
        /// </summary>
        public IWebProxy Proxy { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// The maximum number of items that can be waiting to send (default 10000).
        /// </summary>
        public int SendQueueLimit { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// The amount of time an object can wait to be sent before it is considered dead (default 30 minutes).
        /// A dead item will be ignored and removed from the send queue when it is hit.
        /// </summary>
        public TimeSpan SendCacheItemTimeout { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Minimum time between sending items from the queue in ms (default 80ms).
        /// Setting this to lower then 10ms is not recommended.
        /// </summary>
        public ushort SendDelay { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Strategy that is used when the connection is lost. This allows you to automatically try to restore a lost connection without lose of data.
        /// </summary>
        public ReconnectStrategy MyReconnectStrategy { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// If set to true verbose messages will be sent to std out.
        /// </summary>
        public bool DebugMode { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// If the servers certificate is invalid or has errors should we ignore it? true to ignore, false default.
        /// </summary>
        public bool IgnoreCertErrors { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// The cookies to use for this connection.
        /// </summary>
        public CookieContainer Cookies { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Any certificates you wish to use for this connection.
        /// </summary>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Amount time in ms to wait for a clean disconnect to complete (default 20000ms).
        /// </summary>
        public int DisconnectWait { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// The output for debug messages (default Console.Out).
        /// </summary>
        public TextWriter DebugOutput { get; set; }

        public PureWebSocketOptions()
        {
            SendQueueLimit = 10000;
            SendCacheItemTimeout = TimeSpan.FromMinutes(30);
            SendDelay = 80;
            DisconnectWait = 20000;
            DebugOutput = Console.Out;
        }
    }
}
