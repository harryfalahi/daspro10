<template>
  <v-footer dark padless fixed>
    <v-card class="flex" flat tile>
      <v-card-title class="green darken-4 py-10">
        <strong class="subtitle-1">Get connected with us</strong>

        <v-spacer></v-spacer>

        <v-btn v-for="icon in icons" :key="icon" class="mx-4" dark icon>
          <v-icon size="24px">
            {{ icon }}
          </v-icon>
        </v-btn>
      </v-card-title>

      <v-card-text class="py-2 footer darken-3 white--text text-center">
        {{ new Date().getFullYear() }} — <strong>Universitas Riau</strong>
      </v-card-text>
    </v-card>
  </v-footer>
</template>

<script>
  export default {
    data: () => ({
      icons: [
        'fab fa-facebook',
        'fab fa-twitter',
        'fab fa-google-plus',
        'fab fa-linkedin',
        'fab fa-instagram',
      ]
    })
  }
</script>

<style>
  .footer {
    background-color: #033006
  }
</style>