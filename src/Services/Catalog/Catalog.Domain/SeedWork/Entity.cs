using System;

namespace Catalog.Domain.SeedWork
{
    /// <summary>
    /// Base class for domain entities.
    /// </summary>
    public abstract class Entity
    {
        #region Members

        private int? _requestedHashCode;

        #endregion

        #region Properties

        /// <summary>
        /// Get the persistent object identifier.
        /// </summary>
        public virtual Guid Id { get; protected set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment.
        /// </summary>
        /// <returns>True if entity is transient, else false.</returns>
        public Boolean IsTransient()
        {
            return Id == Guid.Empty;
        }

        /// <summary>
        /// Generate identity for this entity.
        /// </summary>
        public void GenerateNewIdentity()
        {
            if (IsTransient())
                Id = IdentityGenerator.NewSequentialGuid();
        }

        /// <summary>
        /// Change current identity for a new non transient identity.
        /// </summary>
        /// <param name="identity">The new identity.</param>
        public void ChangeCurrentIdentity(Guid identity)
        {
            if (identity != Guid.Empty)
                Id = identity;
        }

        #endregion

        #region Overrides Methods

        /// <summary>
        /// <see cref="M:System.Object.Equals"/>
        /// </summary>
        /// <param name="obj"><see cref="M:System.Object.Equals"/></param>
        /// <returns><see cref="M:System.Object.Equals"/></returns>
        public override Boolean Equals(Object obj)
        {
            if (!(obj is Entity))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            var item = (Entity)obj;

            if (item.IsTransient() || IsTransient())
                return false;

            return item.Id == Id;
        }

        /// <summary>
        /// <see cref="M:System.Object.GetHashCode"/>
        /// </summary>
        /// <returns><see cref="M:System.Object.GetHashCode"/></returns>
        public override Int32 GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }

            return base.GetHashCode();
        }

        public static Boolean operator ==(Entity left, Entity right)
        {
            return Equals(left, null) ? Equals(right, null) : left.Equals(right);
        }

        public static Boolean operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        #endregion
    }
}
