interface IPost {
    id: string;
    message: string;
    timestamp: Date;
}

type PostState = {
    posts: IPost[];
}

type PostAction = {
    type: string;
    posts: IPost[];
}

type DispatchType = (args: PostAction) => PostAction;