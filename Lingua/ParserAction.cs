﻿/* Copyright (c) 2009 Richard G. Todd.
 * Licensed under the terms of the Microsoft Public License (Ms-PL).
 */

namespace Lingua
{
    /// <summary>
    /// Defines the action taken during parsing for a specific <see cref="ParserState" /> and <see cref="NonterminalType" />.
    /// </summary>
    /// <remarks>
    /// There are three subclasses of <c>ParserAction</c>: <see cref="ParserActionShift" />, <see cref="ParserActionReduce" /> and <see cref="ParserActionAccept" />.  
    /// <see cref="ActionType" /> identifies the specific subclass of a <c>ParserAction</c>.
    /// </remarks>
    public abstract class ParserAction
    {
        #region Fields

        private ParserActionTypes m_actionType;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserAction"/> class.
        /// </summary>
        /// <param name="actionType">A <see cref="ParserActionTypes"/> that identifies the subclass of this <see cref="ParserAction"/>.</param>
        public ParserAction(ParserActionTypes actionType)
        {
            m_actionType = actionType;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the <see cref="ParserActionTypes"/> that identifies the subclass of this <see cref="ParserAction"/>.
        /// </summary>
        public ParserActionTypes ActionType
        {
            get { return m_actionType; }
        }

        #endregion
    }
}
