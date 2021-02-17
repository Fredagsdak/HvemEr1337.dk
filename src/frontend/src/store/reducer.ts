import { ActionTypes } from './action-types';

const initialState: PostState = {
    posts: []
}

const reducer = (
    state: PostState = initialState,
    action: PostAction
): PostState => {
    switch (action.type) {
        case ActionTypes.ADD_POST: {
            const newPost: IPost = {
                message: action.post.message
            };
            return {
                ...state,
                posts: state.posts.concat(newPost)
            };
        };
        case ActionTypes.GET_ALL_POSTS: {
            return state;
        };
        default: return state;
    }
}

export default reducer;
