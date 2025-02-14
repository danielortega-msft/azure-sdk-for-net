// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Message Media Content. </summary>
    public partial class AcsMessageMediaContent
    {
        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        /// <param name="mimeType"> The MIME type of the file this media represents. </param>
        /// <param name="mediaId"> The media identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mimeType"/> or <paramref name="mediaId"/> is null. </exception>
        internal AcsMessageMediaContent(string mimeType, string mediaId)
        {
            Argument.AssertNotNull(mimeType, nameof(mimeType));
            Argument.AssertNotNull(mediaId, nameof(mediaId));

            MimeType = mimeType;
            MediaId = mediaId;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        /// <param name="mimeType"> The MIME type of the file this media represents. </param>
        /// <param name="mediaId"> The media identifier. </param>
        /// <param name="fileName"> The filename of the underlying media file as specified when uploaded. </param>
        /// <param name="caption"> The caption for the media object, if supported and provided. </param>
        /// <param name="animated"> Set to true if the sticker is animated; false otherwise. </param>
        internal AcsMessageMediaContent(string mimeType, string mediaId, string fileName, string caption, bool? animated)
        {
            MimeType = mimeType;
            MediaId = mediaId;
            FileName = fileName;
            Caption = caption;
            Animated = animated;
        }

        /// <summary> The MIME type of the file this media represents. </summary>
        public string MimeType { get; }
        /// <summary> The media identifier. </summary>
        public string MediaId { get; }
        /// <summary> The filename of the underlying media file as specified when uploaded. </summary>
        public string FileName { get; }
        /// <summary> The caption for the media object, if supported and provided. </summary>
        public string Caption { get; }
        /// <summary> Set to true if the sticker is animated; false otherwise. </summary>
        public bool? Animated { get; }
    }
}
