module.exports = ({ env }) => ({
  'strapi-plugin-sso': {
    enabled: true,
    config: { 
      OIDC_CLIENT_ID: env('AUTH__CLIENT_ID'),
      OIDC_CLIENT_SECRET: env('AUTH__CLIENT_SECRET'),

      OIDC_AUTHORIZATION_ENDPOINT: `${env('AUTH__SERVER')}`, 
      OIDC_TOKEN_ENDPOINT: `${env('AUTH__SERVER')}/connect/token`,
      OIDC_USER_INFO_ENDPOINT: `${env('AUTH__SERVER')}/connect/userinfo`,
      OIDC_USER_INFO_ENDPOINT_WITH_AUTH_HEADER: false, 
      OIDC_GRANT_TYPE: 'authorization_code',
 

 
      USE_WHITELIST: true, 
    }
  }
});
