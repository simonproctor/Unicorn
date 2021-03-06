﻿using Sitecore.Data.Items;
using Sitecore.Data.Serialization.ObjectModel;

namespace Unicorn.Serialization.Sitecore.Formatting
{
	public interface IFiatFormatterLogger
	{
		void CreatedNewItem(Item targetItem);

		void MovedItemToNewParent(Item newParentItem, Item oldParentItem, Item movedItem);

		void RemovingOrphanedVersion(Item versionToRemove);

		void RenamedItem(Item targetItem, string oldName);

		void ChangedBranchTemplate(Item targetItem, string oldBranchId);

		void ChangedTemplate(Item targetItem, TemplateItem oldTemplate);

		void AddedNewVersion(Item newVersion);

		void SkippedMissingTemplateField(Item item, SyncField field);

		void WroteBlobStream(Item item, SyncField field);

		void UpdatedChangedFieldValue(Item item, SyncField field, string oldValue);

		void ResetFieldThatDidNotExistInSerialized(global::Sitecore.Data.Fields.Field field);

		void SkippedPastingIgnoredField(Item item, SyncField field);
	}
}
