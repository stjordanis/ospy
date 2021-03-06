﻿//
// Copyright (c) 2009 Ole André Vadla Ravnås <oleavr@gmail.com>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace oSpy.Capture
{
    [Serializable]
    public class MessageEvent : Event
    {
        private MessageContext context = MessageContext.MESSAGE_CTX_INFO;

        public MessageContext Context
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
            }
        }

        public MessageEvent(EventCoordinator coordinator, InvocationOrigin invocationOrigin)
            : base(coordinator, invocationOrigin)
        {
        }

        public MessageEvent(EventCoordinator coordinator, InvocationOrigin invocationOrigin, string message)
            : base(coordinator, invocationOrigin)
        {
            SetMessage(message);
        }

        public MessageEvent(EventCoordinator coordinator, InvocationOrigin invocationOrigin, string format, params object[] args)
            : base(coordinator, invocationOrigin)
        {
            SetMessage(format, args);
        }
    }
}
