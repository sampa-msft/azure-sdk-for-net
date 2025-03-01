// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Email.Models
{
    /// <summary> Status of an email message that was sent previously. </summary>
    public partial class SendStatusResult
    {
        /// <summary> Initializes a new instance of SendStatusResult. </summary>
        /// <param name="messageId"> System generated id of an email message sent. </param>
        /// <param name="status"> The type indicating the status of a request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        internal SendStatusResult(string messageId, SendStatus status)
        {
            if (messageId == null)
            {
                throw new ArgumentNullException(nameof(messageId));
            }

            MessageId = messageId;
            Status = status;
        }

        /// <summary> System generated id of an email message sent. </summary>
        public string MessageId { get; }
        /// <summary> The type indicating the status of a request. </summary>
        public SendStatus Status { get; }
    }
}
