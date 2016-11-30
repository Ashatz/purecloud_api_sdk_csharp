using System;
using System.Collections.Generic;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Client
{
    public static class NotificationTopics
    {
        public static Dictionary<string, Type> Topics;

        static NotificationTopics()
        {
            Topics = new Dictionary<string, Type>
            { 
              {"v2.contentmanagement.documents.{id}", typeof(DocumentDataNotification)},
              {"v2.contentmanagement.workspaces.{id}.documents", typeof(DocumentDataNotification)},
              {"v2.routing.queues.{id}.conversations", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.conversations.callbacks", typeof(CallbackConversationNotification)},
              {"v2.routing.queues.{id}.conversations.calls", typeof(CallConversationNotification)},
              {"v2.routing.queues.{id}.conversations.chats", typeof(ChatConversationNotification)},
              {"v2.routing.queues.{id}.conversations.cobrowseSessions", typeof(CobrowseConversationNotification)},
              {"v2.routing.queues.{id}.conversations.emails", typeof(EmailConversationNotification)},
              {"v2.routing.queues.{id}.conversations.screenshares", typeof(ScreenShareConversationNotification)},
              {"v2.routing.queues.{id}.conversations.socialexpressions", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.conversations.videos", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.users", typeof(QueueMemberNotification)},
              {"v2.users.{id}.alerting.heartbeat.alerts", typeof(HeartBeatAlertNotification)},
              {"v2.users.{id}.alerting.heartbeat.rules", typeof(HeartBeatRuleNotification)},
              {"v2.users.{id}.alerting.interactionstats.alerts", typeof(InteractionStatAlertNotification)},
              {"v2.users.{id}.alerting.interactionstats.rules", typeof(InteractionStatRuleNotification)},
              {"v2.users.{id}.conversations", typeof(ConversationNotification)},
              {"v2.users.{id}.conversations.callbacks", typeof(CallbackConversationNotification)},
              {"v2.users.{id}.conversations.calls", typeof(CallConversationNotification)},
              {"v2.users.{id}.conversations.chats", typeof(ChatConversationNotification)},
              {"v2.users.{id}.conversations.cobrowseSessions", typeof(CobrowseConversationNotification)},
              {"v2.users.{id}.conversations.emails", typeof(EmailConversationNotification)},
              {"v2.users.{id}.conversations.screenshares", typeof(ScreenShareConversationNotification)},
              {"v2.users.{id}.conversations.socialexpressions", typeof(SocialConversationNotification)},
              {"v2.users.{id}.conversations.videos", typeof(VideoConversationNotification)},
              {"v2.users.{id}.conversationsummary", typeof(UserConversationSummaryNotification)},
              {"v2.users.{id}.fax.documents", typeof(FaxDataNotification)},
              {"v2.users.{id}.outofoffice", typeof(OutOfOfficeNotification)},
              {"v2.users.{id}.presence", typeof(UserPresenceNotification)},
              {"v2.users.{id}.routingStatus", typeof(UserRoutingStatusNotification)},
              {"v2.users.{id}.userrecordings", typeof(RecordingDataNotification)},
              {"v2.users.{id}.voicemail.messages", typeof(VoicemailMessageNotification)},
            };
        }
    }
}