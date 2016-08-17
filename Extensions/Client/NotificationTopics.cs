using System.Collections.Generic;

namespace ININ.PureCloudApi.Client
{
    public static class NotificationTopics
    {
        public static Dictionary<string, string> Topics;

        static NotificationTopics()
        {
            Topics = new Dictionary<string, string>
            { 
              {"v2.routing.queues.{id}.conversations", "ConversationNotification"},
              {"v2.routing.queues.{id}.conversations.callbacks", "CallbackConversationNotification"},
              {"v2.routing.queues.{id}.conversations.calls", "CallConversationNotification"},
              {"v2.routing.queues.{id}.conversations.chats", "ChatConversationNotification"},
              {"v2.routing.queues.{id}.conversations.emails", "EmailConversationNotification"},
              {"v2.users.{id}.alerting.interactionstats.alerts", "InteractionStatAlertNotification"},
              {"v2.users.{id}.alerting.interactionstats.rules", "InteractionStatRuleNotification"},
              {"v2.users.{id}.conversations", "ConversationNotification"},
              {"v2.users.{id}.conversations.callbacks", "CallbackConversationNotification"},
              {"v2.users.{id}.conversations.calls", "CallConversationNotification"},
              {"v2.users.{id}.conversations.chats", "ChatConversationNotification"},
              {"v2.users.{id}.conversations.emails", "EmailConversationNotification"},
              {"v2.users.{id}.conversations.socialexpressions", "SocialConversationNotification"},
              {"v2.users.{id}.conversations.videos", "VideoConversationNotification"},
              {"v2.users.{id}.conversationsummary", "UserConversationSummaryNotification"},
              {"v2.users.{id}.outofoffice", "OutOfOfficeNotification"},
              {"v2.users.{id}.presence", "UserPresenceNotification"},
            };
        }
    }
}